﻿using UnityEngine;
/// <summary>
/// Información sobre un objeto para poblar el espacio.
/// 
/// Developed by Alejandro Benítez & Fernando Paniagua. 2019.
/// </summary>
[System.Serializable]
[CreateAssetMenu(fileName = "AutoGeneratedObject", menuName = "Magical World Generator/Auto Generated Object", order = 1)]

public class AutoGeneratedObject : ScriptableObject
{
    [Header("Prefab del objeto a crear")]
    public GameObject prefab;
    [Header("Número de instancias a crear")]
    public int numberOfInstances;
    [Header("Desplazamiento sobre la superficie en el eje Y")]
    public float yOffset;
    [Header("Escala mínima")]
    [Range(0, 10)]
    public float minScaleRange = 1;
    [Header("Escala máxima")]
    [Range(0, 10)]
    public float maxScaleRange = 1;
    [Header("Rotación aleatoria")]
    public bool randomYRotation;
    
}
