namespace DocumentModel.Wordprocessing;

/// <summary>
///   External Content Import Properties.
/// </summary>
public class AltChunkProperties: ModelElement
{
  /// <summary>
  ///   Specifies if any style definitions present Iin the imported content shall be overridden 
  ///   by identical styles present Iin the host WordprocessingML document. 
  ///   If this element's val attribute is true, then any style exists Iin both the imported content and main document 
  ///   shall be maintained on the imported content by redefining the style name and/or ID as needed. 
  ///   Conversely, if this element's val attribute is false, any style which exists Iin both the imported content and main document 
  ///   shall apply the style form the main document Iin place of the style Iin the imported content.
  /// </summary>
  public bool? MatchSource { get; set; }
}
