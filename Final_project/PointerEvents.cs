using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PointerEvents : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public GameObject option;
    public GameObject canvas;
    public GameObject pointer;
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color enterColor = Color.white;
    [SerializeField] private Color downColor = Color.white;
    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        meshRenderer.material.color = enterColor;
        print("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        meshRenderer.material.color = normalColor;
        print("Exit");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        meshRenderer.material.color = downColor;
        print("Down");
        Debug.Log(option.gameObject.name);
        if (option.gameObject.name == "Resume")
        {
            canvas.SetActive(false);
            pointer.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (option.gameObject.name == "Menu")
        {
            SceneManager.LoadScene(sceneName: "menu_room");
        }
        else if (option.gameObject.name == "Air Combat")
        {
            SceneManager.LoadScene(sceneName: "grass hill");
            Time.timeScale = 1f;
        }
         else if (option.gameObject.name == "Ground Combat")
        {
            SceneManager.LoadScene(sceneName: "GroundLevel1VR");
            Time.timeScale = 1f;
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        meshRenderer.material.color = enterColor;
        print("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke();
        print("Click");
    }
    
}
