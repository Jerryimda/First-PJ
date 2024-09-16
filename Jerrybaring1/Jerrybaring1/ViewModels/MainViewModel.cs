using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Jerrybaring1.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        //View에서 '변수를' 바인딩 할 수 있게 ObservableProperty를 적어준다//
        [ObservableProperty]
        private ViewModelBase _currentPage;

        public MainViewModel()
        {
            CurrentPage = new MainPageViewModel();
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
            CurrentPage = new MainPageViewModel(); 
        }

        [RelayCommand]
        private void Seminar()
        {
            CurrentPage = new SeminarTapViewModel();
        }
    }
}

//본인부터 자세히 적고 제자에게 말하시오.. ㅋㅋ
//그리고 제안할 것이 하나더 있소
//9월 15일까지는 가르쳐준걸 또 모른다고 하여도 한숨쉬지 말고 웃으면서 알려주시오~
//ㅇㅇㅇㅇㅇㅇ
