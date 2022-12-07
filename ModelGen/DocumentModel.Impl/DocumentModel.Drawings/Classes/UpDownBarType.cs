namespace DocumentModel.Drawings;

/// <summary>
/// Defines the UpDownBarType Class.
/// </summary>
public class UpDownBarTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType>, UpDownBarType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
