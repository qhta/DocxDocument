namespace DocumentModel;

/// <summary>
/// Specifies the set of characters which shall be restricted from beginning or ending a line for runs of text 
/// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
/// when the contents of the document are displayed. 
/// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
/// or automatic detection methods outside the scope of /IEC 29500.
/// </summary>
public record NoBreakKinsoku
{
  public string? Lang { get; set; }
  public string? Val { get; set; }
}
