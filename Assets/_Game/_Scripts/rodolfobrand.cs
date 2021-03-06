using UnityEngine;

public class rodolfobrand : MonoBehaviour
{
    

    public static bool jericharles()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.CheckPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.CAMERA");
        return (result[0] == AndroidRuntimePermissions.Permission.Denied || result[1] == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool rosannecrain()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.RequestPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.CAMERA");
        return (result[0] == AndroidRuntimePermissions.Permission.Granted && result[1] == AndroidRuntimePermissions.Permission.Granted);
    }

    

    public static bool kayealexander()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.CheckPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.READ_EXTERNAL_STORAGE");
        return (result[0] == AndroidRuntimePermissions.Permission.Denied || result[1] == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool torifraser()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.RequestPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.READ_EXTERNAL_STORAGE");
        return (result[0] == AndroidRuntimePermissions.Permission.Granted && result[1] == AndroidRuntimePermissions.Permission.Granted);
    }

    

    public static bool marciacraft()
    {
        AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.CheckPermission("android.permission.RECORD_AUDIO");
        return (result == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool tarafelix()
    {
        AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.RequestPermission("android.permission.RECORD_AUDIO");
        return (result == AndroidRuntimePermissions.Permission.Granted);
    }

    
}
