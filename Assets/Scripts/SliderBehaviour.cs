using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    GenerateTreeUI treeObj;

    [SerializeField] Slider basePolygonSlider;
    [SerializeField] TextMeshProUGUI basePolygonSliderValue;

    [SerializeField] Slider trunkThicknessSlider;
    [SerializeField] TextMeshProUGUI trunkThicknessSliderValue;

    [SerializeField] Slider treeHeightSlider;
    [SerializeField] TextMeshProUGUI treeHeightSliderValue;

    [SerializeField] Slider firstBranchHeightSlider;
    [SerializeField] TextMeshProUGUI firstBranchHeightSliderValue;

    [SerializeField] Slider twistinessSlider;
    [SerializeField] TextMeshProUGUI twistinessSliderValue;

    [SerializeField] Slider leafSizeSlider;
    [SerializeField] TextMeshProUGUI leafSizeSliderValue;

    int basePolygonValue;
    int trunkThicknessValue;
    int treeHeightValue;
    int firstBranchHeightValue;
    int twistinessValue;
    int leafSizeValue;

    // Start is called before the first frame update
    void Start()
    {
        treeObj = GetComponent<GenerateTreeUI>();
        basePolygonValue = (int)basePolygonSlider.value;
        trunkThicknessValue = (int)trunkThicknessSlider.value;
        treeHeightValue = (int)treeHeightSlider.value;
        firstBranchHeightValue = (int)firstBranchHeightSlider.value;
        twistinessValue = (int)twistinessSlider.value;
        leafSizeValue = (int)leafSizeSlider.value;
    }

    public void BasePolygonChange(float value) {
        basePolygonSliderValue.text = value.ToString("0");
        treeObj._basePolygon = (int) value;
    }

    public void TrunkThicknessChange(float value) {
        trunkThicknessSliderValue.text = value.ToString("0");
        treeObj._trunkThickness = ((int)value) / 100f;
    }

    public void TreeHeightChange(float value) {
        treeHeightSliderValue.text = value.ToString("0");
        treeObj._floorHeight = value / 100f;
    }

    public void FirstBranchHeightChange(float value) {
        firstBranchHeightSliderValue.text = value.ToString("0") + "%";
        treeObj._firstBranchHeight = value * treeObj._floorHeight * 2 / 100f;
    }

    public void TwistinessChange(float value) {
        twistinessSliderValue.text = value.ToString("0");
        treeObj._twistiness = (int) value;
    }

    public void LeafSizeChange(float value) {
        leafSizeSliderValue.text = value.ToString("0");
        treeObj._leavesSize = (int) value;
    }

    public void ResetValues() {
        basePolygonSlider.value = basePolygonValue;
        trunkThicknessSlider.value = trunkThicknessValue;
        treeHeightSlider.value = treeHeightValue;
        firstBranchHeightSlider.value = firstBranchHeightValue;
        twistinessSlider.value = twistinessValue;
        leafSizeSlider.value = leafSizeValue;
        treeObj._basePolygon = basePolygonValue;
        treeObj._trunkThickness = trunkThicknessValue / 100f;
        treeObj._floorHeight = treeHeightValue / 100f;
        treeObj._firstBranchHeight = firstBranchHeightValue * treeObj._floorHeight * 2 / 100f;
        treeObj._twistiness = twistinessValue;
        treeObj._leavesSize = leafSizeValue;
    }
}
