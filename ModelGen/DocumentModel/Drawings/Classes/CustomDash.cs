namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a custom dashing scheme. It is a list of dash stop elements which represent building block atoms upon which the custom dashing scheme is built.
/// </summary>
public partial class CustomDash
{
  public DocumentModel.ElementCollection<DocumentModel.Drawings.DashStop>? Items { get; set; }
  
}
