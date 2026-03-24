using System.Collections;
using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange?view=office-pia"/>
public partial interface ShapeRange
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.item?view=office-pia"/>
  public Shape Item(object Index);
  /// <summary>
  /// Invokes `Align`.
  /// </summary>
  /// <param name="AlignCmd">The `AlignCmd` parameter.</param>
  /// <param name="RelativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.align?view=office-pia"/>
  public void Align(MsoAlignCmd AlignCmd, MsoTriState RelativeTo);
  /// <summary>
  /// Invokes `Apply`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.apply?view=office-pia"/>
  public void Apply();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `Distribute`.
  /// </summary>
  /// <param name="DistributeCmd">The `DistributeCmd` parameter.</param>
  /// <param name="RelativeTo">The `RelativeTo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.distribute?view=office-pia"/>
  public void Distribute(MsoDistributeCmd DistributeCmd, MsoTriState RelativeTo);
  /// <summary>
  /// Invokes `Duplicate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.duplicate?view=office-pia"/>
  public ShapeRange Duplicate();
  /// <summary>
  /// Invokes `Flip`.
  /// </summary>
  /// <param name="FlipCmd">The `FlipCmd` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.flip?view=office-pia"/>
  public void Flip(MsoFlipCmd FlipCmd);
  /// <summary>
  /// Invokes `IncrementLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementleft?view=office-pia"/>
  public void IncrementLeft(float Increment);
  /// <summary>
  /// Invokes `IncrementRotation`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementrotation?view=office-pia"/>
  public void IncrementRotation(float Increment);
  /// <summary>
  /// Invokes `IncrementTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.incrementtop?view=office-pia"/>
  public void IncrementTop(float Increment);
  /// <summary>
  /// Invokes `Group`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.group?view=office-pia"/>
  public Shape Group();
  /// <summary>
  /// Invokes `PickUp`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.pickup?view=office-pia"/>
  public void PickUp();
  /// <summary>
  /// Invokes `Regroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.regroup?view=office-pia"/>
  public Shape Regroup();
  /// <summary>
  /// Invokes `RerouteConnections`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.rerouteconnections?view=office-pia"/>
  public void RerouteConnections();
  /// <summary>
  /// Invokes `ScaleHeight`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scaleheight?view=office-pia"/>
  public void ScaleHeight
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  /// <summary>
  /// Invokes `ScaleWidth`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.scalewidth?view=office-pia"/>
  public void ScaleWidth
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.select?view=office-pia"/>
  public void Select(object Replace);
  /// <summary>
  /// Invokes `SetShapesDefaultProperties`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.setshapesdefaultproperties?view=office-pia"/>
  public void SetShapesDefaultProperties();
  /// <summary>
  /// Invokes `Ungroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.ungroup?view=office-pia"/>
  public ShapeRange Ungroup();
  /// <summary>
  /// Invokes `ZOrder`.
  /// </summary>
  /// <param name="ZOrderCmd">The `ZOrderCmd` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.zorder?view=office-pia"/>
  public void ZOrder(MsoZOrderCmd ZOrderCmd);
  /// <summary>
  /// Invokes `CanvasCropLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropleft?view=office-pia"/>
  public void CanvasCropLeft(float Increment);
  /// <summary>
  /// Invokes `CanvasCropTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascroptop?view=office-pia"/>
  public void CanvasCropTop(float Increment);
  /// <summary>
  /// Invokes `CanvasCropRight`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropright?view=office-pia"/>
  public void CanvasCropRight(float Increment);
  /// <summary>
  /// Invokes `CanvasCropBottom`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.canvascropbottom?view=office-pia"/>
  public void CanvasCropBottom(float Increment);
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.cut?view=office-pia"/>
  public void Cut();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.copy?view=office-pia"/>
  public void Copy();
  /// <summary>
  /// Invokes `MergeShapes`.
  /// </summary>
  /// <param name="MergeCmd">The `MergeCmd` parameter.</param>
  /// <param name="PrimaryShape">The `PrimaryShape` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shaperange.mergeshapes?view=office-pia"/>
  public void MergeShapes(MsoMergeCmd MergeCmd, Shape PrimaryShape);
}

