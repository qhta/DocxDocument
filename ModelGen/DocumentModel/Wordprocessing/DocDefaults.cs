namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of default paragraph and run properties which shall be applied to every paragraph and run in the current WordprocessingML document. These properties are applied first in the style hierarchy; therefore they are superseded by any further conflicting formatting but apply if no further formatting is present.
/// </summary>
public partial class DocDefaults
{
  
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  public DMW.RunPropertiesDefault? RunPropertiesDefault { get; set; }
  
  
  /// <summary>
  ///   Default Paragraph Properties.
  /// </summary>
  public DMW.ParagraphPropertiesDefault? ParagraphPropertiesDefault { get; set; }
  
}
