namespace DocumentModel.Drawing;

/// <summary>
/// Table Background.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectPropertiesType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectReference))]
public class TableBackground: ITableBackground
{
}
