namespace DocumentModel.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public class MajorFontImpl: DocumentModel.Drawings.FontCollectionTypeImpl, MajorFont
{
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
