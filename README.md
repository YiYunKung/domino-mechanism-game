# 🕹️骨牌機關遊戲 Domino Mechanism Game
* 以多重的機關觸發連鎖反應，使工人走向終點旗幟達成最終目的

## 實際畫面
<img width="983" height="650" alt="螢幕擷取畫面 2025-07-16 235406" src="https://github.com/user-attachments/assets/2363b34e-4d40-4f2c-afa2-f2fe9643ef81" />
<br><br>

* 遊戲開始後，按下鍵盤 `A` 鍵，最上方的骨牌會開始一連串的傾倒
<img width="984" height="656" alt="螢幕擷取畫面 2025-07-16 235835" src="https://github.com/user-attachments/assets/ba37c382-e55f-4b24-b1d3-c37fa1312260" />
<br><br>

* 最後一塊骨牌落下並打到紅球，紅球開始移動
* 粉紅色平面的 `Bounciness` 設為 1，且 `Bounce Combine` 設為 `Maximum`，為可彈跳的材質
* 該黃色平面有設定 `Hinge Joint`，當紅球撞到黃色平面後會推動紅色方塊開始移動
* 藍色平面則是平滑、無摩擦力的材質，其中 `Dynamic Friction`、`Static Friction` 皆設為 0，以及 `Friction Combine` 設為 `Minimum`
<img width="978" height="652" alt="螢幕擷取畫面 2025-07-16 235859" src="https://github.com/user-attachments/assets/c85bb381-85e0-49ca-98a9-1c217f4eef6c" />
<br><br>

* 紅方塊往下掉落，觸發了地板上的紅色按鈕
* 當按下紅色按鈕，工人便會向前走向終點旗幟，在螢幕顯示 "Finish!!" 字樣
<img width="978" height="652" alt="螢幕擷取畫面 2025-07-16 235919" src="https://github.com/user-attachments/assets/2672cedc-97a9-4cdf-b6ce-7683e8fb9a30" />
