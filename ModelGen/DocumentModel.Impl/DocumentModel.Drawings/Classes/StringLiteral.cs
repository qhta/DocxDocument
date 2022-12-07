namespace DocumentModel.Drawings;

/// <summary>
/// String Literal.
/// </summary>
public class StringLiteralImpl: DocumentModel.Drawings.StringDataType1Impl, StringLiteral
{
  public StrDataExtensionList? StrDataExtensionList
  {
    get;
    set;
  }
  
}
