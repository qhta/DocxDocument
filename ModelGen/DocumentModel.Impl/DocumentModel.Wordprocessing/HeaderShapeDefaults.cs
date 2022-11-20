namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IShapeDefaults))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IShapeLayout))]
public class HeaderShapeDefaults: IHeaderShapeDefaults
{
}
