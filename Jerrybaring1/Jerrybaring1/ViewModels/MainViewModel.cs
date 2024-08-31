using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Jerrybaring1.ViewModels
{
    public class LineCard
    {
        public LineCard(string? line, string? name, string? job)
        {
            Line = line;
            Name = name;
            Job = job;
        }

        public string? Line { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public Brush? Brush { get; set; }

    }

    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<LineCard> _lineCards = new ObservableCollection<LineCard>();
        public MainViewModel()
        {

            LineCards.Add(new LineCard("\"2030 인재들의 이직이 잦은데 어떻게 하죠?\" 전 이렇게 답해요. \"요즘 진짜 인재는 한 회사에 오래 다닐 수 없어요.\"",
                                        "김호",
                                        "더랩에이치 대표"));
            LineCards.Add(new LineCard("오래 일하는 방법요? 조직에서 시키기 전에 제가 하고 싶은 일을 조직에 필요한 일로 만들었어요. 그래야 계속할 수 있으니까요.",
                                        "김지수",
                                        "기자"));
            LineCards.Add(new LineCard("저희 콘텐츠 핵심은 '발견성'입니다. 모든 콘텐츠를 직접 큐레이션·재가공하는 이유죠. 구독자가 다양하게 경험할 수 있도록요.",
                                        "이성호",
                                        "밀리의 서재 콘텐츠 사업부 본부장"));
            LineCards.Add(new LineCard("상업용 부동산시장 트렌드 궁금하세요? 요즘 사람들은 어디에서 살고 싶어 하는지, 일하는 형태는 어떻게 바뀔지부터 생각해보세요.",
                                        "지효진",
                                        "마스턴투자운용 글로벌리서치팀 팀장"));
        }

        [RelayCommand]
        private void Add()
        {
            LineCards.Add(new LineCard("상업용 부동산시장 트렌드 궁금하세요? 요즘 사람들은 어디에서 살고 싶어 하는지, 일하는 형태는 어떻게 바뀔지부터 생각해보세요.",
                                        "지효진",
                                        "마스턴투자운용 글로벌리서치팀 팀장"));
        }

        [RelayCommand]
        private void hamsoo()
        {
            Hamsoo3 = "Winner";
        }
        [RelayCommand]
        private void hamsoo2() 
        {
            Hamsoo3 = "Loser";
        }
        [ObservableProperty]
        string _hamsoo3;
       
    }
}
