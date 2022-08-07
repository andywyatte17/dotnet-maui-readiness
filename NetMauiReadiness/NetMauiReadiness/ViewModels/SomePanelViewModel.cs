using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMauiReadiness.ViewModels
{
	public class SomePanelViewModel
	{
		public string IpsumF
		{
			get
			{
				var strings = Ipsum.Split('\n')
					.Select(x => x.Trim())
					.Where(x => x.Length > 0);
				var fs = "<p>" + string.Join("</p><p>", strings) + "</p>";
				return fs;
			}
		}

		public string Ipsum => @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec et dui est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque sit amet enim porttitor, maximus massa sit amet, tincidunt leo. Integer nibh odio, bibendum a gravida eget, ultricies ac ante. Vivamus quis vehicula dolor. Ut luctus, lectus tristique egestas lobortis, felis arcu lacinia nisi, vel rhoncus elit mi sit amet ex. Donec porta ullamcorper luctus. Aenean et egestas nisl, vitae porttitor elit. Phasellus volutpat blandit ante, vel vestibulum orci imperdiet et. Sed sed tellus est. In interdum at risus quis aliquet. Suspendisse quam erat, feugiat ac auctor sed, imperdiet vel diam. Duis ex justo, ultrices sit amet ipsum vel, vulputate rhoncus diam. Curabitur in ullamcorper diam. Nunc porttitor lacus non ex vulputate, a semper nulla gravida. Nunc luctus lacus vitae elit lacinia ultricies.

Morbi nec turpis ac felis facilisis tempus id eu lacus. Nunc fermentum ante ac purus sodales, sit amet consectetur turpis aliquet. Quisque scelerisque ultricies libero vel eleifend. Sed lobortis ex eu urna consectetur, in rhoncus metus laoreet. Cras volutpat ornare urna. Ut volutpat leo sem, eget fringilla tortor convallis sit amet. Quisque rutrum id purus bibendum mollis. Mauris ut metus aliquet, tincidunt enim vitae, vehicula augue. Mauris vel nisl lectus. Proin ut mattis nibh. Maecenas a massa ultrices tortor bibendum placerat. Sed et quam lacinia, vestibulum augue eu, porttitor tortor. Phasellus non lacinia lacus. Duis laoreet leo at efficitur vulputate.

Nulla facilisi. Donec urna velit, maximus eu elit at, sagittis congue sem. Proin consequat elit at eros consectetur, a dignissim est consectetur. Suspendisse vitae tortor sapien. Proin tempus mattis turpis, sed hendrerit erat. Donec odio dolor, semper vitae justo dictum, finibus semper nisl. Phasellus sapien lectus, lobortis non sem sit amet, viverra sollicitudin tortor.

Suspendisse neque dolor, varius sed mollis eget, maximus non nulla. Mauris euismod vel risus sed venenatis. Nam ipsum diam, laoreet et felis quis, dictum laoreet est. Pellentesque tincidunt sodales facilisis. Morbi pellentesque, justo nec dignissim posuere, magna massa pharetra tellus, in porta tellus neque at augue. Nulla facilisi. Phasellus vitae odio in mauris faucibus congue eu non metus.

Nunc blandit sem sit amet libero elementum congue. Integer faucibus, risus vitae tempus malesuada, tellus nunc varius lacus, id cursus lorem metus nec mi. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut dictum euismod sem, eu vehicula lectus dictum vitae. Quisque vel porttitor nisl. Aenean bibendum nisl est, non tempor nulla vestibulum eget. Nullam in lacus nec lacus euismod imperdiet. Morbi vestibulum ipsum vel ultrices bibendum.";
	}
}
