
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.PlayerLoop;

//ͨ���̳�ScriptableObjectʵ�ִ��������͵������ļ�
[CreateAssetMenu(menuName ="Tile State")]
public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;
}
