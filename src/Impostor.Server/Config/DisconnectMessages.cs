namespace Impostor.Server.Config
{
    public static class DisconnectMessages
    {
        public const string Error = "服务器内部发生错误。" +
                                    "请查看服务器控制台以获取更多信息。" +
                                    "如果问题持续出现，请在 Impostor GitHub 上报告该问题。";

        public const string Destroyed = "你尝试加入的游戏正在被销毁。" +
                                        "请创建一个新游戏。";

        public const string NotImplemented = "对于运行在服务器重定向模式下的服务器，" +
                                             "Impostor 尚未实现游戏列表功能。";

        public const string UsernameLength = "你的用户名太长，请将其缩短。";

        public const string UsernameIllegalCharacters = "你的用户名包含非法字符，请将其移除。";

        public const string VersionClientTooOld = "请更新游戏以在此服务器上游玩。";

        public const string VersionServerTooOld = "你的客户端版本太新，请更新 Impostor 服务器以进行游玩。";

        public const string VersionUnsupported = "你的客户端版本不受支持，请更新游戏和/或 Impostor 服务器。";
    }
}