namespace DocxEd.Helpers;
public class DynamicDataTemplateSelector : DataTemplateSelector
{
  public override DataTemplate? SelectTemplate(object item, DependencyObject container)
  {
    FrameworkElement? element = container as FrameworkElement;
    if (element != null)
    {
      if (item is TypeInfoViewModel)
        return element.FindResource("TypeInfoLinkTemplate") as DataTemplate;
      else
        return element.FindResource("TextBlockTemplate") as DataTemplate;
    }
    return null;
  }
}
