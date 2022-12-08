namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public class SubSuperscriptImpl: ModelElementImpl, SubSuperscript
{
  public DocumentFormat.OpenXml.Math.SubSuperscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubSuperscript?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public SubSuperscriptProperties? SubSuperscriptProperties
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
  /// Subscript (Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get;
    set;
  }
  
}
