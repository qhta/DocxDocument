namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public class VbaSuppDataImpl: ModelElement<DocumentFormat.OpenXml.Office.Word.VbaSuppData>, VbaSuppData
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocEvents? DocEvents
  {
    get;
    set;
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public Mcds? Mcds
  {
    get;
    set;
  }
  
}
