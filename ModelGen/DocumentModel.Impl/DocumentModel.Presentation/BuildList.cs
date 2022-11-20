namespace DocumentModel.Presentation;

/// <summary>
/// Build List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildDiagram))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildParagraph))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildGraphics))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildOleChart))]
public class BuildList: IBuildList
{
}
