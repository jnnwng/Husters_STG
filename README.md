![STGame](https://github.com/leonardozcm/Husters_STG/blob/master/img/boss4.gif)
# Husters_STG
一个STG游戏
  
## 游戏剧情
游戏模拟的是华科学生期末复习时的情形。
主角为一名华科学生，在期末复习的时间段他一如往常地前往自习室复习功课，但到达教学楼后所看到的一切让他傻眼了：教具们一个个就像被释放了飞行魔法一般浮在空中！桌椅板凳，像是幽灵一样徘徊着，粉笔盒也浮在空中，里面的粉笔不时以飞快的速度向四面八方发射，周围也有不少前来自习的同学被困住导致无法进入教室复习……
没有时间发呆了！到底我们扮演的主角能否突破这重重困难，抵达自习室成功复习呢？

## 游戏玩法
### 基本玩法
游戏的基本玩法为2D的横版STG，在STG中属于弹幕密集型（参考“东方Project”）。
弹幕密集型STG有个特点是同屏弹幕量巨大，总的观感非常震撼，不熟练的玩家初见一般会手忙脚乱。由于弹幕密度大，一般玩家角色的击中判定区会很小，这样玩家就可以通过细小的操作来规避子弹。
总之，这个类型的游戏一般考察玩家的微操，尽量存活下去是首要目标。
### 核心玩法
为了契合期末复习的主题，我们将设置BOSS战来摸你期末考试，即关卡的BOSS为一个老师角色，而与这个角色的战斗部分是玩法的精华。原因有三：不同于一般游戏杂兵，BOSS拥有更高的弹幕量（有时会铺满整个屏幕，非常有震撼感）；BOSS有多阶段，攻击模式变化大；BOSS血量更多等。
同时，为了模拟考试的不同科目，角色的子弹形式也是有不同的，这里以颜色区分，而BOSS设计时也拥有不同的颜色阶段，只有与阶段对应的颜色的子弹才能对BOSS造成伤害（这又对玩家的操作提出了要求）。

## 角色设计
游戏角色的设计主要分为两大类，分别是玩家角色（下称自机）和敌方角色（下称敌机）的设计。
### 自机设计
自机又称PC，是玩家能控制的角色。
在本游戏中角色的表现为一个骑着卷轴的半秃华科男学生（很形象！），发射的子弹用彩色的圆点表示。
![playerCharacter](https://github.com/leonardozcm/Husters_STG/blob/master/img/playerCharacter.jpg)
虽然角色的体型不算小，但实际上被击中的判定区只有中间的一个红点。
操作上，角色设计为WASD的操作，J键为发射子弹，按住可以持续发射。
同样，在需要微操时可以按住shift键来放慢角色的移动速度，这在弹幕密集时很有用！
Z键可以更换子弹的形式，击败微积分老师后我们需要更换为英语知识，因为下一堂是英语考试！
![currentBullet](https://github.com/leonardozcm/Husters_STG/blob/master/img/currentBullet.jpg)

## 敌机设计
### 杂兵设计
杂兵是游戏中数量最多，单个强度较弱的敌机，表现为行动模式单一、共计模式单一、弹幕数量少、生命值少。但是大量的杂兵也会给玩家造成麻烦。
杂兵的种类有很多的，本游戏中有如下：
#### 1.粉笔盒1
![box1](https://github.com/leonardozcm/Husters_STG/blob/master/img/box_1.png)  
弹幕类型：以玩家当前位置为方向连续发射粉笔弹幕
#### 2.粉笔盒2
![box2](https://github.com/leonardozcm/Husters_STG/blob/master/img/box_2.png)  
弹幕类型：先向前端弧形区域发射一圈弹幕，弹幕暂停一秒后集体冲向玩家目标位置
#### 3.粉笔盒3
![box3](https://github.com/leonardozcm/Husters_STG/blob/master/img/box_3.png)  
弹幕类型：同时向四面八方发射弹幕
#### 4.椅子
![chair](https://github.com/leonardozcm/Husters_STG/blob/master/img/chair.png)  
无弹幕
#### 5.水龙头
![Dragon](https://github.com/leonardozcm/Husters_STG/blob/master/img/dragon.png)  
弹幕类型：向前端直线发射一段冲击水流
### BOSS设计
正如前文所说，BOSS战是游戏的高潮阶段，因此BOSS的设计也是游戏的关键，本游戏的BOSS目前设计了一种。
其拥有三种阶段：
#### 第一阶段：BOSS按照固定路线高速移动，移动过程中向上、下发射较大的弹幕
![boss_1](https://github.com/leonardozcm/Husters_STG/blob/master/img/boss_1.png)  
#### 第二阶段：BOSS连续发射大范围定向弹幕，同时召唤两个杂兵发射大范围弹幕
![boss_2](https://github.com/leonardozcm/Husters_STG/blob/master/img/boss_2.png)  
#### 第三阶段：BOSS继续发射大范围定向弹幕，同时间隔发射跟踪弹幕
![boss_3](https://github.com/leonardozcm/Husters_STG/blob/master/img/boss_3.png)  
#### 第四阶段：BOSS连续上下快速移动，发射定向弹幕
![boss_4](https://github.com/leonardozcm/Husters_STG/blob/master/img/boss_4.png)  
