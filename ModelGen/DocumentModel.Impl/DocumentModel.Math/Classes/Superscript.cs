namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public class SuperscriptImpl: ModelElementImpl, Superscript
{
  public DocumentFormat.OpenXml.Math.Superscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Superscript?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public SuperscriptProperties? SuperscriptProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get;
    set;
  }
  
}
