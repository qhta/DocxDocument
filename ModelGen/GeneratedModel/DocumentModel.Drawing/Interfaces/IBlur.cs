namespace DocumentModel.Drawing;

public interface IBlur // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public long? Radius { get ; set; }

  public bool? Grow { get ; set; }

}
