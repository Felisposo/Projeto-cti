#pragma checksum "C:\Users\felip\Documents\git\Projeto-cti\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea89538c6469026d39451a6581a98d7c01d64139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\felip\Documents\git\Projeto-cti\Views\_ViewImports.cshtml"
using Projeto_cti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\Documents\git\Projeto-cti\Views\_ViewImports.cshtml"
using Projeto_cti.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea89538c6469026d39451a6581a98d7c01d64139", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558e789309b424544315a43ae1039bee120fa5fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card "">
                    <div class=""card-header "">
                        <h4 class=""card-title"">Temperatura da Estufa</h4>
                    </div>
                    <div class=""card-body "">
                        <canvas id=""graficoTemperatura""></canvas>
                        <div class=""stats"">
                            <i class=""fa fa-history""></i> Updated 1 Hour ago
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card "">
                    <div class=""card-header "">
                        <h4 class=""card-title"">Úmidade da Estufa</h4>
                    </div>
                    <div class=""card-body "">
                        <div class=""chart"">
                            <canvas id=""graficoUmidade""></canvas");
            WriteLiteral(@">
                        </div>
                        <div class=""stats"">
                            <i class=""fa fa-history""></i> Updated 1 Hour ago
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"    </div>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.1/Chart.min.js""></script>
<script src=""https://raw.githubusercontent.com/chartjs/Chart.js/master/samples/utils.js""></script>
<script>
    var horas = ['0AM','1AM','2AM','3AM','4AM','5AM','6AM','7AM','8AM','9AM','10AM','11AM','12PM','1PM','2PM','3PM','4PM','5PM','9PM','10PM','11PM']

    var graficoTemperatura = document.getElementById('graficoTemperatura');
    var configTemperatura = {
            type: 'line',

        data: {
            labels: ['2000', '2001', '2002', '2003', '2004', '2005'],

            datasets: [
                {
                    label: 'Crecimento Populacional',
                    data: [173448346, 175885229, 178276128, 180619108, 182911487, 185150806]
                }
            ]
        },
        options: {
			responsive: true,
			tooltips: {
				mode: 'index',
			},
			hover: {
				mode: 'index'
			},
			scales: {
				xAxes: [{
					scaleLabel: {
						displ");
            WriteLiteral(@"ay: true,
						labelString: 'Horas'
					}
				}],
				yAxes: [{
					stacked: true,
					scaleLabel: {
						display: true,
						labelString: 'Temperatura'
					}
				}]
			}
		}
    }
    var chartTemperatura = new Chart(graficoTemperatura, configTemperatura);


    var graficoUmidade = document.getElementById('graficoUmidade');
    var configUmidade = {
            type: 'line',

        data: {
            labels: ['2000', '2001', '2002', '2003', '2004', '2005'],

            datasets: [
                {
                    label: 'Crecimento Populacional',
                    data: [173448346, 175885229, 178276128, 180619108, 182911487, 185150806]
                }
            ]
        },
        options: {
			responsive: true,
			tooltips: {
				mode: 'index',
			},
			hover: {
				mode: 'index'
			},
			scales: {
				xAxes: [{
					scaleLabel: {
						display: true,
						labelString: 'Horas'
					}
				}],
				yAxes: [{
					stacked: true,
					scale");
            WriteLiteral(@"Label: {
						display: true,
						labelString: 'Úmidade'
					}
				}]
			}
		}
    }
    var chartUmidade = new Chart(graficoUmidade, configUmidade );

    document.getElementById('adicionaHora').addEventListener('click', function() {
		var horasTemperaura = horas[configTemperatura.data.labels.length % horas.length];
		configTemperatura.data.labels.push(horasTemperaura);
        configTemperatura.data.datasets.forEach(function(dataset) {
			dataset.data.push(randomScalingFactor());
		});

		var horasUmidade = horas[configUmidade.data.labels.length % horas.length];
		configUmidade.data.labels.push(horasUmidade);
        configUmidade.data.datasets.forEach(function(dataset) {
			dataset.data.push(randomScalingFactor());
		});
		window.myLine.update();
	});

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
