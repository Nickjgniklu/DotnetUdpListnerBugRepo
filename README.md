# DotnetUdpListnerBugRepo
This a simple console app to show that calling `IPGlobalProperties.GetIPGlobalProperties().GetActiveUdpListeners();` on Ubuntu 18.04 WSL will throw an error.

See https://github.com/dotnet/runtime/issues/44500
