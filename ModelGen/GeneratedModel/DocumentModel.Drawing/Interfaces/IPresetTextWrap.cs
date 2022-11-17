namespace DocumentModel.Drawing;

public interface IPresetTextWrap // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public TextShape? Preset { get ; set; }

  public IAdjustValueList? AdjustValueList { get ; set; }

}
