public class SceneConfigManager : SingletonMonoBehaviour<SceneConfigManager>
{
    public void Awake()
    {
        if (this != Instance)
        {
            Destroy(this);
            return;
        }
    }
}