namespace DocumentModel.Drawings;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public class InvertSolidFillFormatImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>, InvertSolidFillFormat
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties9? ShapeProperties
  {
    get;
    set;
  }
  
}
