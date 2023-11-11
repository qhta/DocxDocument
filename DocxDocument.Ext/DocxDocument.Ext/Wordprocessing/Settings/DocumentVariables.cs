namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifiesspecifies the presence of documentvariables in a WordprocessingML. 
/// A document variable is a storage location for arbitrary customer data in name/value pairs 
/// that is persisted in a given WordprocessingML document.
/// [Note: This mechanism is maintained for legacy compatibility only, and should be avoided 
/// in favor of the custom XML data support defined in /IEC 29500. end note]
/// </summary>
[Obsolete]
public partial class DocumentVariables : NamedElementCollection<DXW.DocumentVariables, DXW.DocumentVariable, DMW.DocumentVariable>
{
  public DocumentVariables() : base() { }

  public DocumentVariables(DXW.DocumentVariables openXmlElement) : base(openXmlElement) { }

  public bool TryGetValue(string key, [MaybeNullWhen(false)][NotNullWhen(true)] out string? value)
  {
    var ok = base.TryGetValue(key, out var documentVariable);
    if (ok && documentVariable!=null)
      value = documentVariable.Val;
    else
      value = null;
    return ok;

  }
}
