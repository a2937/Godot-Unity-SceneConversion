using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodotUnityConvertGame.addons.GodotImporter
{
    public static class GodotSceneBuilder
    {
        class UnityObjectMapping
        {

            public static Dictionary<String, Type> mappingTwoD = new Dictionary<String, Type>()
            {
                { "AudioListener",typeof(AudioListener2D) },
                {"Camera",typeof(Camera2D) },
                {"SpriteRenderer",typeof(Sprite2D) }
            };


            public static Dictionary<int, string> IdToTypeName = new Dictionary<int, string>()
        {
            { 1,  "GameObject" },
            { 2,  "Component" },
            { 3,  "LevelGameManager" },
            { 4,  "Transform" },
            { 5,  "TimeManager" },
            { 6,  "GlobalGameManager" },
            { 8,  "Behaviour" },
            { 9,  "GameManager" },
            { 11,  "AudioManager" },
            { 12,  "ParticleAnimator" },
            { 13,  "InputManager" },
            { 15,  "EllipsoidParticleEmitter" },
            { 17,  "Pipeline" },
            { 18,  "EditorExtension" },
            { 19,  "Physics2DSettings" },
            { 20,  "Camera" },
            { 21,  "Material" },
            { 23,  "MeshRenderer" },
            { 25,  "Renderer" },
            { 26,  "ParticleRenderer" },
            { 27,  "Texture" },
            { 28,  "Texture2D" },
            { 29,  "SceneSettings" },
            { 30,  "GraphicsSettings" },
            { 33,  "MeshFilter" },
            { 41,  "OcclusionPortal" },
            { 43,  "Mesh" },
            { 45,  "Skybox" },
            { 47,  "QualitySettings" },
            { 48,  "Shader" },
            { 49,  "TextAsset" },
            { 50,  "Rigidbody2D" },
            { 51,  "Physics2DManager" },
            { 53,  "Collider2D" },
            { 54,  "Rigidbody" },
            { 55,  "PhysicsManager" },
            { 56,  "Collider" },
            { 57,  "Joint" },
            { 58,  "CircleCollider2D" },
            { 59,  "HingeJoint" },
            { 60,  "PolygonCollider2D" },
            { 61,  "BoxCollider2D" },
            { 62,  "PhysicsMaterial2D" },
            { 64,  "MeshCollider" },
            { 65,  "BoxCollider" },
            { 66,  "SpriteCollider2D" },
            { 68,  "EdgeCollider2D" },
            { 72,  "ComputeShader" },
            { 74,  "AnimationClip" },
            { 75,  "ConstantForce" },
            { 76,  "WorldParticleCollider" },
            { 78,  "TagManager" },
            { 81,  "AudioListener" },
            { 82,  "AudioSource" },
            { 83,  "AudioClip" },
            { 84,  "RenderTexture" },
            { 87,  "MeshParticleEmitter" },
            { 88,  "ParticleEmitter" },
            { 89,  "Cubemap" },
            { 90,  "Avatar" },
            { 91,  "AnimatorController" },
            { 92,  "GUILayer" },
            { 93,  "RuntimeAnimatorController" },
            { 94,  "ScriptMapper" },
            { 95,  "Animator" },
            { 96,  "TrailRenderer" },
            { 98,  "DelayedCallManager" },
            { 102,  "TextMesh" },
            { 104,  "RenderSettings" },
            { 108,  "Light" },
            { 109,  "CGProgram" },
            { 110,  "BaseAnimationTrack" },
            { 111,  "Animation" },
            { 114,  "MonoBehaviour" },
            { 115,  "MonoScript" },
            { 116,  "MonoManager" },
            { 117,  "Texture3D" },
            { 118,  "NewAnimationTrack" },
            { 119,  "Projector" },
            { 120,  "LineRenderer" },
            { 121,  "Flare" },
            { 122,  "Halo" },
            { 123,  "LensFlare" },
            { 124,  "FlareLayer" },
            { 125,  "HaloLayer" },
            { 126,  "NavMeshAreas" },
            { 127,  "HaloManager" },
            { 128,  "Font" },
            { 129,  "PlayerSettings" },
            { 130,  "NamedObject" },
            { 131,  "GUITexture" },
            { 132,  "GUIText" },
            { 133,  "GUIElement" },
            { 134,  "PhysicMaterial" },
            { 135,  "SphereCollider" },
            { 136,  "CapsuleCollider" },
            { 137,  "SkinnedMeshRenderer" },
            { 138,  "FixedJoint" },
            { 140,  "RaycastCollider" },
            { 141,  "BuildSettings" },
            { 142,  "AssetBundle" },
            { 143,  "CharacterController" },
            { 144,  "CharacterJoint" },
            { 145,  "SpringJoint" },
            { 146,  "WheelCollider" },
            { 147,  "ResourceManager" },
            { 148,  "NetworkView" },
            { 149,  "NetworkManager" },
            { 150,  "PreloadData" },
            { 152,  "MovieTexture" },
            { 153,  "ConfigurableJoint" },
            { 154,  "TerrainCollider" },
            { 155,  "MasterServerInterface" },
            { 156,  "TerrainData" },
            { 157,  "LightmapSettings" },
            { 158,  "WebCamTexture" },
            { 159,  "EditorSettings" },
            { 160,  "InteractiveCloth" },
            { 161,  "ClothRenderer" },
            { 162,  "EditorUserSettings" },
            { 163,  "SkinnedCloth" },
            { 164,  "AudioReverbFilter" },
            { 165,  "AudioHighPassFilter" },
            { 166,  "AudioChorusFilter" },
            { 167,  "AudioReverbZone" },
            { 168,  "AudioEchoFilter" },
            { 169,  "AudioLowPassFilter" },
            { 170,  "AudioDistortionFilter" },
            { 171,  "SparseTexture" },
            { 180,  "AudioBehaviour" },
            { 181,  "AudioFilter" },
            { 182,  "WindZone" },
            { 183,  "Cloth" },
            { 184,  "SubstanceArchive" },
            { 185,  "ProceduralMaterial" },
            { 186,  "ProceduralTexture" },
            { 191,  "OffMeshLink" },
            { 192,  "OcclusionArea" },
            { 193,  "Tree" },
            { 194,  "NavMeshObsolete" },
            { 195,  "NavMeshAgent" },
            { 196,  "NavMeshSettings" },
            { 197,  "LightProbesLegacy" },
            { 198,  "ParticleSystem" },
            { 199,  "ParticleSystemRenderer" },
            { 200,  "ShaderVariantCollection" },
            { 205,  "LODGroup" },
            { 206,  "BlendTree" },
            { 207,  "Motion" },
            { 208,  "NavMeshObstacle" },
            { 210,  "TerrainInstance" },
            { 212,  "SpriteRenderer" },
            { 213,  "Sprite" },
            { 214,  "CachedSpriteAtlas" },
            { 215,  "ReflectionProbe" },
            { 216,  "ReflectionProbes" },
            { 220,  "LightProbeGroup" },
            { 221,  "AnimatorOverrideController" },
            { 222,  "CanvasRenderer" },
            { 223,  "Canvas" },
            { 224,  "RectTransform" },
            { 225,  "CanvasGroup" },
            { 226,  "BillboardAsset" },
            { 227,  "BillboardRenderer" },
            { 228,  "SpeedTreeWindAsset" },
            { 229,  "AnchoredJoint2D" },
            { 230,  "Joint2D" },
            { 231,  "SpringJoint2D" },
            { 232,  "DistanceJoint2D" },
            { 233,  "HingeJoint2D" },
            { 234,  "SliderJoint2D" },
            { 235,  "WheelJoint2D" },
            { 238,  "NavMeshData" },
            { 240,  "AudioMixer" },
            { 241,  "AudioMixerController" },
            { 243,  "AudioMixerGroupController" },
            { 244,  "AudioMixerEffectController" },
            { 245,  "AudioMixerSnapshotController" },
            { 246,  "PhysicsUpdateBehaviour2D" },
            { 247,  "ConstantForce2D" },
            { 248,  "Effector2D" },
            { 249,  "AreaEffector2D" },
            { 250,  "PointEffector2D" },
            { 251,  "PlatformEffector2D" },
            { 252,  "SurfaceEffector2D" },
            { 258,  "LightProbes" },
            { 271,  "SampleClip" },
            { 272,  "AudioMixerSnapshot" },
            { 273,  "AudioMixerGroup" },
            { 290,  "AssetBundleManifest" },
            { 1001,  "Prefab" },
            { 1002,  "EditorExtensionImpl" },
            { 1003,  "AssetImporter" },
            { 1004,  "AssetDatabase" },
            { 1005,  "Mesh3DSImporter" },
            { 1006,  "TextureImporter" },
            { 1007,  "ShaderImporter" },
            { 1008,  "ComputeShaderImporter" },
            { 1011,  "AvatarMask" },
            { 1020,  "AudioImporter" },
            { 1026,  "HierarchyState" },
            { 1027,  "GUIDSerializer" },
            { 1028,  "AssetMetaData" },
            { 1029,  "DefaultAsset" },
            { 1030,  "DefaultImporter" },
            { 1031,  "TextScriptImporter" },
            { 1032,  "SceneAsset" },
            { 1034,  "NativeFormatImporter" },
            { 1035,  "MonoImporter" },
            { 1037,  "AssetServerCache" },
            { 1038,  "LibraryAssetImporter" },
            { 1040,  "ModelImporter" },
            { 1041,  "FBXImporter" },
            { 1042,  "TrueTypeFontImporter" },
            { 1044,  "MovieImporter" },
            { 1045,  "EditorBuildSettings" },
            { 1046,  "DDSImporter" },
            { 1048,  "InspectorExpandedState" },
            { 1049,  "AnnotationManager" },
            { 1050,  "PluginImporter" },
            { 1051,  "EditorUserBuildSettings" },
            { 1052,  "PVRImporter" },
            { 1053,  "ASTCImporter" },
            { 1054,  "KTXImporter" },
            { 1101,  "AnimatorStateTransition" },
            { 1102,  "AnimatorState" },
            { 1105,  "HumanTemplate" },
            { 1107,  "AnimatorStateMachine" },
            { 1108,  "PreviewAssetType" },
            { 1109,  "AnimatorTransition" },
            { 1110,  "SpeedTreeImporter" },
            { 1111,  "AnimatorTransitionBase" },
            { 1112,  "SubstanceImporter" },
            { 1113,  "LightmapParameters" },
            { 1120,  "LightmapSnapshot"}
        };
        }

        private static void PrintDictionary(Dictionary<string, object> dict)
        {
            foreach (var kvp in dict)
            {
                GD.Print($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        public static void BuildScene(Dictionary<string, dynamic> unityScene, bool isThreeD = false)
        {
            if (isThreeD)
            {
                // Deal with all that fancy light stuff
            }
            else
            {
                try
                {


                    var root = new Node2D();
                    root.Name = "Root";

                    // Skip all the lightmap and render stuff until I know what to do. 
                    unityScene.Remove("OcclusionCullingSettings");
                    unityScene.Remove("RenderSettings");
                    unityScene.Remove("LightmapSettings");
                    unityScene.Remove("NavMeshSettings"); // I don't know how that works
                    unityScene.Remove("SceneRoots"); // I don't what to do with it; I mean it's great for comparison reasons maybe
                    Node2D currentNode = new Node2D();
                    for (int i = 0; i < unityScene.Count; i++)
                    {
                        var objectValues = unityScene.ElementAt(i).Value;

                        if (unityScene.ElementAt(i).Key.Equals("GameObject"))
                        {
                            PrintDictionary(objectValues);
                            currentNode = new Node2D();

                            currentNode.Name = objectValues["m_Name"];
                            root.AddChild(currentNode);
                            currentNode.Owner = root;
                        }
                        else if (unityScene.ElementAt(i).Key.Equals("Transform"))
                        {
                            Dictionary<string, dynamic> scale = objectValues["m_LocalScale"];
                            Dictionary<string, dynamic> position = objectValues["m_LocalPosition"];
                            currentNode.Scale = new Vector2(float.Parse(scale["x"]), float.Parse(scale["y"]));
                            currentNode.Position = new Vector2(float.Parse(position["x"]), float.Parse(position["y"]));
                        }
                        else if (unityScene.ElementAt(i).Key.Equals("SpriteRenderer"))
                        {
                            Dictionary<string, dynamic> colors = objectValues["m_Color"];
                            Dictionary<string, dynamic> scale = objectValues["m_Size"];
                            var Sprite2D = new Sprite2D();
                            Sprite2D.Name = currentNode.Name;
                            Sprite2D.Scale = currentNode.Scale;
                            Sprite2D.Position = currentNode.Position;
                            root.RemoveChild(currentNode);
                            currentNode.Owner = null;

                            root.AddChild(Sprite2D);
                            Sprite2D.Owner = root;

                            Sprite2D.Modulate = new Color(float.Parse(colors["r"]), float.Parse(colors["g"]), float.Parse(colors["b"]), float.Parse(colors["a"]));
                            Sprite2D.Scale = new Vector2(float.Parse(scale["x"]), float.Parse(scale["y"]));
                            currentNode = Sprite2D;
                        }
                        else
                        {
                            var nodeType = UnityObjectMapping.mappingTwoD[unityScene.ElementAt(i).Key];
                            if (nodeType != null)
                            {
                                var newNode = Activator.CreateInstance(nodeType);

                                currentNode.AddChild(newNode as Node2D);
                            }
                            else
                            {
                                GD.Print(unityScene.ElementAt(i).Key + " needs a listing");
                            }
                        }

                    }

                    /*
                    var node = new Node2D();
                    var body = new RigidBody2D();
                    var collision = new CollisionShape2D();

                    // Create the object hierarchy.
                    body.AddChild(collision);
                    node.AddChild(body); 
                    // Change owner of `body`, but not of `collision`.
                    body.Owner = node;
                    */



                    var scene = new PackedScene();

                    // Only `node` and `body` are now packed.
                    Error result = scene.Pack(root);
                    if (result == Error.Ok)
                    {
                        DirAccess.MakeDirRecursiveAbsolute("res://generated_scenes/");
                        Error error = ResourceSaver.Save(scene, "res://generated_scenes/new_gen_scene.tscn"); // Or "user://..."
                        if (error != Error.Ok)
                        {
                            GD.PushError("An error occurred while saving the scene to disk.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    GD.PrintErr(ex);
                }
            }
        }
    }
}
