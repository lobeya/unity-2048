
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.PlayerLoop;

//通过继承ScriptableObject实现创建该类型的数据文件
[CreateAssetMenu(menuName ="Tile State")]
public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;
}
