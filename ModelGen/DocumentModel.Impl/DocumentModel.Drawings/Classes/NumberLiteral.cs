namespace DocumentModel.Drawings;

/// <summary>
/// Number Literal.
/// </summary>
public class NumberLiteralImpl: DocumentModel.Drawings.NumberDataTypeImpl, NumberLiteral
{
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
