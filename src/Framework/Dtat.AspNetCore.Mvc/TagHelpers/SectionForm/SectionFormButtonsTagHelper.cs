﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Dtat.AspNetCore.Mvc.TagHelpers.SectionForm;

/// <summary>
/// Checked
/// </summary>
[HtmlTargetElement(tag: "section-form-buttons",
	ParentTag = "section-form",
	TagStructure = TagStructure.NormalOrSelfClosing)]
public class SectionFormButtonsTagHelper : TagHelper
{
	public async override Task ProcessAsync
		(TagHelperContext context, TagHelperOutput output)
	{
		// **************************************************
		var originalContents =
			await
			output.GetChildContentAsync();
		// **************************************************

		// **************************************************
		var div = new TagBuilder(tagName: "div");

		div.AddCssClass(value: "mb-3");

		div.InnerHtml.AppendHtml(content: originalContents);
		// **************************************************

		// **************************************************
		output.TagName = null;
		output.TagMode = TagMode.StartTagAndEndTag;
		output.Content.SetHtmlContent(htmlContent: div);
		// **************************************************
	}
}
