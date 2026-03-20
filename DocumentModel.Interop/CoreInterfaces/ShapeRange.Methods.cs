using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ShapeRange
{
  public Shape Item(object Index);
  public void Align(MsoAlignCmd AlignCmd, MsoTriState RelativeTo);
  public void Apply();
  public void Delete();
  public void Distribute(MsoDistributeCmd DistributeCmd, MsoTriState RelativeTo);
  public ShapeRange Duplicate();
  public void Flip(MsoFlipCmd FlipCmd);
  public void IncrementLeft(float Increment);
  public void IncrementRotation(float Increment);
  public void IncrementTop(float Increment);
  public Shape Group();
  public void PickUp();
  public Shape Regroup();
  public void RerouteConnections();
  public void ScaleHeight
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  public void ScaleWidth
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  public void Select(object Replace);
  public void SetShapesDefaultProperties();
  public ShapeRange Ungroup();
  public void ZOrder(MsoZOrderCmd ZOrderCmd);
  public void CanvasCropLeft(float Increment);
  public void CanvasCropTop(float Increment);
  public void CanvasCropRight(float Increment);
  public void CanvasCropBottom(float Increment);
  public void Cut();
  public void Copy();
  public void MergeShapes(MsoMergeCmd MergeCmd, Shape PrimaryShape);
}
