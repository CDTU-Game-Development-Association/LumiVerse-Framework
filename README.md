# LumiVerse-Framework
光界，一个用来打GJ的Godot框架

[![猫猫计数器](https://starry-trace-sky-moe-counter.vercel.app/get/@LumiVerse-Framework?theme=rule34)](https://github.com/StarrySky-skyler/LumiVerse-Framework)

[![编程语言C#](https://img.shields.io/badge/编程语言-CSharp-blue.svg?style=for-the-badge)](#)
[![游戏引擎Godot v4.3](https://img.shields.io/badge/游戏引擎-Godotv4.3-pink.svg?style=for-the-badge)](#)
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](https://github.com/StarrySky-skyler/LumiVerse-Framework/blob/main/LICENSE)

## 封装功能

> 命名规范，函数方法名均以Yumihoshi开头

### 调试模块`YumihoshiDebug`

1. `public static void Print<T>(string funcType, string message)`

> 打印 Info 信息到 Godot Console

- `T`: 当前调用该方法时的脚本类名，方便定位调用位置，
- `funcType`: 功能模块名称，可随便输，
- `message`: 日志信息



输出示例
```
[初始化] InventoryUi 2025-02-13 15:53:20.783
>>> 设置列数为4列
```

`Error<T>`和`Warn<T>`与上类似

### 全屏切换

1. `public static void SwitchFullScreen(bool isFullScreen, int windowId = 0)`

> 转换全屏/窗口状态

- `isFullScreen`: 要转换为全屏/窗口，全屏为`True`，窗口为`False`
- `windowId`: 窗口id，默认为`0`，即当前窗口和`DisplayServer.WindowSetMode`中的`windowId`相同

2. `public static void SwitchFullScreenAuto(int windowId = 0)`

> 转换全屏/窗口状态，与上不同的是，如果当前是全屏，则切换为窗口，反之亦然

> [!IMPORTANT]
> 本项目遵循[MIT License](https://github.com/Yumihoshi/LumiVerse-Framework/blob/main/LICENSE)