using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//	(2017.12.05)	SelectionBase 属性の挙動
//	GameObjectにこの属性を付けると、シーンビューでの選択の起点になる
//	子供のオブジェクトは、この属性を持つ親を検索
//	無ければそのまま選択される
//	属性を持つ親があればそれを選択 → その親を選択すると、直前に選択した子供が選択
//	※Unityエディター拡張では「下の階層から親に向かって順番に選択される」とあるが、属性を見つけた時点でそれ以上親までは見に行かない
//	※自身に属性が付いている場合、親の属性を見に行かないで選択完了になる
[SelectionBase]
public class Selector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
