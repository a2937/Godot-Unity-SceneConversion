#if TOOLS
using ConversionLogic;
using Godot;
using GodotUnityConvertGame.addons.GodotImporter;

[Tool]
public partial class Main : EditorPlugin
{


    private Control _dock;

    private EditorFileDialog? _fileDialog;

    public override void _EnterTree()
    {
        try
        {
            _dock = GD.Load<PackedScene>("res://addons/GodotImporter/MyDock.tscn").Instantiate<Control>();
            AddControlToDock(DockSlot.LeftUl, _dock);
            _fileDialog = new EditorFileDialog();
            if (_fileDialog != null)
            {
                _fileDialog.Access = EditorFileDialog.AccessEnum.Filesystem;
                _dock.AddChild(_fileDialog);
                _fileDialog.FileMode = EditorFileDialog.FileModeEnum.OpenFile;
                _fileDialog.Size = new Vector2I(800, 800);
                _dock.GetNode<Button>("Button").Pressed += OpenDialog;
                _fileDialog.FileSelected += OnFileDialogFolderSelected;
            }
        }
        catch (Exception ex)
        {
            GD.PrintErr(ex);
        }


        // Initialization of the plugin goes here.
    }


    private void OpenDialog()
    {
        GD.Print("Open sesame");
        _fileDialog?.Popup();
    }

    public override void _ExitTree()
    {
        try
        {
            if (_fileDialog != null)
            {
                _dock.GetNode<Button>("Button").Pressed -= OpenDialog;
                _fileDialog.FileSelected -= OnFileDialogFolderSelected;
                _fileDialog.QueueFree();
                _fileDialog = null;
            }
        }
        catch (Exception ex)
        {
            GD.PrintErr(ex);
        }

        RemoveControlFromDocks(_dock);
        _dock.Free();
        // Clean-up of the plugin goes here.
    }

    private void OnFileDialogFolderSelected(string path)
    {
        // Handle the selected file path here.
        GD.Print("Selected folder: " + path);
        if (path.EndsWith(".unity"))
        {
            var content = UnitySceneReader.ReadFile(path);
            GodotSceneBuilder.BuildScene(content);
        }
    }



}
#endif