using System.Text;

namespace MinimalAPI.Security.Settings;

public static class Setting
{
    private static string SecretKey = "6ceccd7405ef4b00b2630009be568cfa";
    public static byte[] GenerateSecretKey() => Encoding.ASCII.GetBytes(SecretKey);
}