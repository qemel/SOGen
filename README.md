> [!WARNING]
> このパッケージは現在作成中です

## SOGen

SOGenはボイラープレートとなるScriptableObjectのDatabaseを生成するライブラリです。

## Setup

### Requirements

- Unity 2022.3 LTS 以降

### Install

1. Unity Package Managerを開く
2. `Add package from git URL...`を選択
3. URLを入力

```
https://github.com/qemel/SOGen.git?path=Assets/SOGen
```

### Usage

```csharp
// 1. 列挙型でIDを定義
public enum SamplePrefabID
{
    Player,
    Enemy1,
    Enemy2
}

// 2. ScriptableObjectクラスを定義し、DatabaseOf属性を付与
namespace Scripts
{
    [DatabaseOf(typeof(SamplePrefabID),　typeof(SamplePrefabSO))]
    [CreateAssetMenu(fileName = nameof(SamplePrefabSO), menuName = "Project/" + nameof(SamplePrefabSO))]
    public partial class SamplePrefabSO : ScriptableObject　// partialであることに注意
    {
    }
}

// 3. 自動生成されたコードを使用
var playerPrefab = prefabDatabase.Get(SamplePrefabID.Player);
```

