# 🛡️ Unity 掉落物閃避遊戲專案

<div align="center">

[![Unity](https://img.shields.io/badge/Unity-2021.3+-black?style=for-the-badge&logo=unity)](https://unity.com/)
[![License](https://img.shields.io/badge/License-Educational-blue?style=for-the-badge)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20macOS-green?style=for-the-badge)](https://github.com/ONK2130/unity-puzzle)

</div>


## 📖 專案簡介

這是一個使用 Unity 製作的躲避遊戲，玩家控制角色閃避從天而降的障礙物。遊戲共分為三種難度：簡單、普通、困難，難度越高，掉落物速度越快。遊戲最終會依據三個難度的存活時間加總顯示總成績。

### ✨ 主要特色

- 🟢 **多種難度模式** - Eazy、Normal、Difficult 模式選擇
- 🕹️ **直覺操作** - 使用鍵盤左右鍵控制角色移動
- ⏱️ **成績計算** - 以存活時間作為成績基準
- 📈 **成績統整** - 結束畫面呈現所有難度的總成績
- 🧠 **簡潔場景流程** - 從開始畫面到結算畫面流暢切換

## 📁 專案結構

```
UnityFinalExam-main/
├── Assets/
│   ├── Resource/                   # 遊戲使用的資源與 Prefab
│   │   ├── FallingObjectEazy.prefab
│   │   ├── FallingObjectNormal.prefab
│   │   ├── FallingObjectDifficult.prefab
│   ├── Scenes/                     # 遊戲場景
│   │   ├── StartScene.unity       # 開始畫面
│   │   ├── GameEazy.unity         # 簡單模式場景
│   │   ├── GameNormal.unity       # 普通模式場景
│   │   ├── GameDifficult.unity    # 困難模式場景
│   │   ├── ScoreScene.unity       # 總成績結算場景
│   ├── Scripts/                    # 遊戲控制腳本
│   │   ├── GameManager.cs         # 控制遊戲流程與倒數
│   │   ├── PlayerMove.cs          # 玩家控制邏輯
│   │   ├── FallingObject.cs       # 障礙物行為控制
│   │   ├── SceneChange.cs         # 場景切換控制
│   │   └── ScoreManager.cs        # 計算與儲存分數
```

## 🎮 遊戲流程

### 1️⃣ 開始畫面 (`StartScene.unity`)

- 顯示開始按鈕與標題
- 點擊「開始」後切換至簡單模式

### 2️⃣ 遊戲進行（Eazy → Normal → Difficult）

- 依序挑戰三種難度，掉落速度逐漸提升
- 玩家控制角色左右閃避
- 玩家每模式開始後記錄存活時間
- 撞到掉落物即結束該模式並自動切換下一關

### 3️⃣ 總結算畫面 (`ScoreScene.unity`)

- 顯示三個難度下的個別分數（存活時間）
- 計算並顯示總存活時間
- 可重新開始遊戲或離開

## 🔧 核心系統

### 📌 遊戲管理 (`GameManager.cs`)

| 功能項目       | 說明                         |
| -------------- | ---------------------------- |
| 計時器         | 計算玩家在每一模式的存活時間 |
| 模式控制       | 控制當前進行的難度與流程     |
| 結束檢測       | 玩家碰到掉落物後觸發結算邏輯 |

### 📌 玩家控制 (`PlayerMove.cs`)

- 支援鍵盤輸入（左右方向鍵）
- 移動邊界限制，防止角色離開畫面
- 碰撞偵測觸發遊戲結束

### 📌 障礙物邏輯 (`FallingObject.cs`)

- 控制障礙物從上方隨機位置落下
- 不同難度使用不同速度的 prefab
- 掉落到底會被回收

### 📌 場景控制 (`SceneSwitch.cs`)

- 有許多場景轉換功能按鈕
- 程式統一置放一份程式檔，方便管理

## 💡 開發特色

### 🏗️ 架構設計

- **Prefab 控制**：依難度使用不同掉落物 Prefab
- **模組化腳本**：遊戲控制、角色控制、掉落邏輯分離
- **結構清晰**：場景與資源各自劃分明確

### 📝 開發管理

- **命名一致性**：Eazy、Normal、Difficult 模式統一命名
- **簡潔 UI**：以文字與基本按鈕實現最小操作成本
- **物件導向**：依據程式功能明確區分

## 🚀 快速開始

### 系統需求

- Unity 2021.3 或更新版本
- 支援 2D 遊戲開發
- Windows 或 macOS 作業系統

### 安裝步驟

1. 將此專案 clone 或下載至本地
   ```bash
   git clone <your-repo-url>
   ```
2. 使用 Unity Hub 開啟該專案
3. 進入 `StartScene` 並按下播放即可開始遊戲

## 📊 技術細節

### 掉落邏輯

- 採用隨機 x 軸生成障礙物
- 使用不同速度的 prefab 區分難度
- 使用 `Destroy()` 回收離開畫面的物件

### 成績計算與管理

- 使用 `ScoreManager` 靜態儲存三階段時間
- 結算畫面使用全域變數個別顯示所有難度的分數

### 場景管理
- 使用 `SceneManager` 製作場景轉換

## 🤝 貢獻指南

歡迎針對本遊戲專案提供建議與改進！

## 📄 授權

此專案為教育用途製作，僅供學習與研究參考。

---

<div align="center">

**Made with ❤️ using Unity**

</div>
