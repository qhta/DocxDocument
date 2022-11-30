namespace DocumentModel;

/// <summary>
/// Represents the abstract base class for all simple types that are used in attributes.
/// </summary>
public interface IOpenXmlSimpleType // : 
{
  public System.Boolean? IsValid { get ; set; }
  
  public System.Boolean? IsEnum { get ; set; }
  
}
