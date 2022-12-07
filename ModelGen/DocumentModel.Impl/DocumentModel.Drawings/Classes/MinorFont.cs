namespace DocumentModel.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public class MinorFontImpl: DocumentModel.Drawings.FontCollectionTypeImpl, MinorFont
{
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
