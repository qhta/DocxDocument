namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SubTimeNodeList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimate))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimateColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimateEffect))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimateMotion))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimateRotation))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAnimateScale))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommand))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IAudio))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IVideo))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISetBehavior))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExclusiveTimeNode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IParallelTimeNode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISequenceTimeNode))]
public class SubTimeNodeList: ISubTimeNodeList
{
}
