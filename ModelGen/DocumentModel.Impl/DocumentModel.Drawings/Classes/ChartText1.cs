namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public class ChartText1Impl: ModelElementImpl, ChartText1
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// String Reference.
  /// </summary>
  public StringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public RichText? RichText
  {
    get;
    set;
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public StringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
