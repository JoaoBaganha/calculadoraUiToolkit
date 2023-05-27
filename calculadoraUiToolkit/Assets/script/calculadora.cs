using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class calculadora : MonoBehaviour
{
    // Declarando as variáveis que serão usadas para armazenar referências aos elementos da interface do usuário
    public UIDocument document; 
    private Button botaoSomar;
    private Button botaoSubtrair;
    private Button botaoMultiplicar;
    private Button botaoDividir;
    private Button _botaoLog;
    private TextField cx1;
    private TextField cx2;
    private Label resultadoOperacao;

    // Método Start é chamado no início do jogo
    void Start()
    {
        // Obtendo referências aos elementos da interface do usuário usando seus nomes
        cx1 = document.rootVisualElement.Q<TextField>("cx1");
        cx2 = document.rootVisualElement.Q<TextField>("cx2");
        botaoSomar = document.rootVisualElement.Q<Button>("botaoSomar");
        botaoSubtrair = document.rootVisualElement.Q<Button>("botaoSubtrair");
        botaoMultiplicar = document.rootVisualElement.Q<Button>("botaoMultiplicar");
        botaoDividir = document.rootVisualElement.Q<Button>("botaoDividir");
        _botaoLog = document.rootVisualElement.Q<Button>("botaoLog");

        // Registrando uma função para ser chamada quando o botão de soma for clicado
        botaoSomar.RegisterCallback<ClickEvent>(resultadoSomar);
        botaoSubtrair.RegisterCallback<ClickEvent>(resultadoSubtrair);
        botaoMultiplicar.RegisterCallback<ClickEvent>(resultadoMultiplicar);
        botaoDividir.RegisterCallback<ClickEvent>(resultadoDividir);
        _botaoLog.RegisterCallback<ClickEvent>(LogAction);

        // Obtendo referência ao elemento da interface do usuário que exibe o resultado da soma
        resultadoOperacao = document.rootVisualElement.Q<Label>("resultadoOperacao");
    }

    // Função a ser chamada quando o botão de soma for clicado
    void resultadoSomar(ClickEvent evt)
    {
        // Obtendo os valores de entrada dos campos de texto e convertendo-os de strings para números de ponto flutuante
        double valor1 = double.Parse(cx1.value);
        double valor2 = double.Parse(cx2.value);

        // Calculando a soma dos valores de entrada
        double soma = valor1 + valor2;

        // Exibindo o resultado da soma na interface do usuário
        resultadoOperacao.text = soma.ToString();
    }

    void resultadoSubtrair(ClickEvent evt)
    {
        // Obtendo os valores de entrada dos campos de texto e convertendo-os de strings para números de ponto flutuante
        double valor1 = double.Parse(cx1.value);
        double valor2 = double.Parse(cx2.value);

        // Calculando a soma dos valores de entrada
        double soma = valor1 - valor2;

        // Exibindo o resultado da soma na interface do usuário
        resultadoOperacao.text = soma.ToString();
    }

    void resultadoMultiplicar(ClickEvent evt)
    {
        // Obtendo os valores de entrada dos campos de texto e convertendo-os de strings para números de ponto flutuante
        double valor1 = double.Parse(cx1.value);
        double valor2 = double.Parse(cx2.value);

        // Calculando a soma dos valores de entrada
        double soma = valor1 * valor2;

        // Exibindo o resultado da soma na interface do usuário
        resultadoOperacao.text = soma.ToString();
    }

    void resultadoDividir(ClickEvent evt)
    {
        // Obtendo os valores de entrada dos campos de texto e convertendo-os de strings para números de ponto flutuante
        double valor1 = double.Parse(cx1.value);
        double valor2 = double.Parse(cx2.value);

        // Calculando a soma dos valores de entrada
        double soma = valor1 / valor2;

        // Exibindo o resultado da soma na interface do usuário
        resultadoOperacao.text = soma.ToString();
    }

    private void LogAction(ClickEvent evt)
    {
        float valor1 = float.Parse(cx1.value);
        float valor2 = float.Parse(cx2.value);
        
        resultadoOperacao.text = $"Resultado: {System.Math.Round(Mathf.Log(valor1, valor2), 2).ToString()}";
    }
}

