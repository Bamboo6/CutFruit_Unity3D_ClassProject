using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FruitCtrl : MonoBehaviour {

    /// <summary>
    /// 水果预制物
    /// </summary>
    public GameObject fruit;

        /// <summary>
        /// 计时初始时间
        /// </summary>
    public float startTime;

    /// <summary>
    /// 给水果的扭矩，让水果旋转，测试随机范围（-300,300）
    /// </summary>
    public float torque;

    /// <summary>
    /// 给水果的随机投掷力，测试随机范围X（-3,3），Y（8,11）
    /// </summary>
    public Vector2 force;


	/// <summary>
    /// 初始化方法，在程序运行的第一帧执行
    /// </summary>
	void Start ()
    {
        /// 设置初始时间为程序运行的当前时刻
        startTime = Time.time;
	}
	
	/// <summary>
    /// 帧更新方法，每一帧执行
    /// </summary>
	void Update ()
    {
        /// 时间流逝量 = 运行当前时刻 - 初始计时时间
        float elaspe = Time.time - startTime;

        /// 如果时间流逝量 > 1 …… 重置初始计时时间，实例化水果对象
        if (elaspe >=1)
        {
            startTime = Time.time;
            GameObject fruitIns = Instantiate(fruit, transform.position, fruit.transform.rotation);

            force.x = Random.Range(-3, 3);
            force.y = Random.Range(8, 11);

            //AddForce(力的向量，力的模式)
            fruitIns.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);

            //扭矩赋值，在-300到300之间随机
            torque = Random.Range(-300, 300);

            //添加一个扭矩，让物体旋转
            fruitIns.GetComponent<Rigidbody2D>().AddTorque(torque);

            //销毁方法，可以延迟执行
            Destroy(fruitIns, 3);
        }
        
	}
}
