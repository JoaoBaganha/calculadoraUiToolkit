using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class calculadora : MonoBehaviour
{

    public UIDocument document;
    private Button botaoSomar;
    private TextField cx1;
    private TextField cx2;
    private Label resultadoSoma;
    // Start is called before the first frame update
    void Start()
    {
        
        cx1 = document.rootVisualElement.Q<TextField>("cx1");
        cx2 = document.rootVisualElement.Q<TextField>("cx2");
        botaoSomar = document.rootVisualElement.Q<Button>("botaoSomar");
        botaoSomar.RegisterCallback<ClickEvent>(resultado);
        resultadoSoma = document.rootVisualElement.Q<Label>("resultadoSoma");

    }

    void resultado(ClickEvent evt)
    {
            double valor1 = double.Parse(cx1.value);
            double valor2 = double.Parse(cx2.value);
            double soma = valor1 + valor2;
            resultadoSoma.text = soma.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
