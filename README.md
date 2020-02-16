# Network-Location-Editor
Windows 10网络位置编辑器

Windows 7自带的网络位置编辑功能，在Windows 10中不复存在，这个项目让你更简易的管理操作系统的网络位置配置。

原理：编辑注册表中的相关配置项：

* \HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles
* \HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged

![主界面](screenshot.jpg)

## 功能

* 编辑或删除多余的网络位置
* 清理注册表中无效的网络位置配置

## 依赖

* [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

## 使用

1. 安装[.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer)
2. 下载绿色可执行文件
