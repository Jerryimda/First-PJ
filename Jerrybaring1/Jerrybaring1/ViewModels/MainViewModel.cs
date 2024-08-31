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
        //View에서 '변수를' 바인딩 할 수 있게 ObservableProperty를 적어준다//
        [ObservableProperty]
        private ViewModelBase _currentPage;

        public MainViewModel()
        {
            CurrentPage = new LineContentViewModel();
        }

        //View에다가 '함수를' 바인딩 할 수 있게 처리해줌
        [RelayCommand]
        private void Add()
        {
         
        }

        //순서 (1)RelayCommand로 붙인 함수를 만든다(기능까지 만든다)
        //(2)View에서 눌렀을 때 해당 함수를 실행시키고 싶ㅇ느 버튼에 가서 command 속성을 바인딩해준다
        [RelayCommand]
        private void ShowTalk()
        {
            CurrentPage = new TalkViewModel();
        }

        [RelayCommand]
        private void ShowLine()
        {
            CurrentPage = new LineContentViewModel(); 
        }
    }
}
