using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviors : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 100.0f)] float m_perception = 5.0f;
    [SerializeField] [Range(0.0f, 5.0f)] float m_strength = 1.0f;
    [SerializeField] AutonomousAgent.eAgentTag m_targetTag = AutonomousAgent.eAgentTag.NONE;

    public float strength { get { return m_strength; } }
    public float perception { get { return m_perception; } }
    public string targetTagName { get { return m_targetTag.ToString(); } }

    public abstract Vector3 Execute(AutonomousAgent agent, AutonomousAgent target, string targetTag ="");
      
}
