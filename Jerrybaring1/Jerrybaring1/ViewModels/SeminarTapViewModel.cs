using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using Jerrybaring1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerrybaring1.ViewModels
{


    public partial class SeminarTapViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<Seminar> _seminars = new ObservableCollection<Seminar>();

        public SeminarTapViewModel()
        {

            Seminars.Add(new Seminar("[오프라인] 어피티 : 2030 직장인의 경제읽기",
                                        "김정인",
                                        "어피티 CCO",
                                        "2024.09.25(수) 19:30"));
            Seminars.Add(new Seminar("[온라인] 어피티 : 2030 직장인의 경제읽기",
                                        "김정인",
                                        "어피티 CCO",
                                        "2024.09.25(수) 19:30"));
            Seminars.Add(new Seminar("[오프라인] 폴인 마케터 클럽",
                                        "김주원",
                                        "현대자동차 국내마케팅팀 책임매니저 외 2명",
                                        "2024.09.27 (금) 19:30"));

        }


    }
}
