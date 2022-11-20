namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Hyperlink List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public class HyperlinkList: IHyperlinkList
{
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector
  {
    get;
    set;
  }
  
}
