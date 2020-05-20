using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Behaviors
{
    [SerializeField] [Range(0.0f, 5.0f)] float m_radius = 2.0f;
    [SerializeField] [Range(0.0f, 5.0f)] float m_forwardDistance = 2.0f;
    [SerializeField] [Range(0.0f, 90.0f)] float m_displacement = 20.0f;

    float m_theta = 0.0f;

    void Start()
    {
        m_theta = Random.Range(0.0f, 360.0f);
    }

    public override Vector3 Execute(AutonomousAgent agent, AutonomousAgent target, string targetTag)
    {
        m_theta += Random.Range(-m_displacement, m_displacement);
        Vector3 randomPoint = Quaternion.AngleAxis(m_theta, Vector3.up) * new Vector3(0.0f, 0.0f, m_radius);

        Vector3 forward = agent.forward * m_forwardDistance;
        Vector3 direction = forward + randomPoint;
        Vector3 desired = direction.normalized * agent.maxSpeed;

        Vector3 steering = desired - agent.velocity;

        return steering;
    }
}
