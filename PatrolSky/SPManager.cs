using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrolSky
{
    //쿼리문을 바로바로 사용할수있게 함수로 정의된 클래스
    class SPManager
    {
        //유닛 업데이트를 쿼리문을 보내주는 함수
        public Boolean 유닛업데이트()
        {
            return false;
        }
        //맵의 지형지물을 추가,삭제,수정등의 작업후 쿼리문을 보내주는 함수
        public Boolean 맵업데이트()
        {
              return false;
        }
        //게임을 하기위해 맵을 불러주는 쿼리 함수
        public Boolean 맵불러오기()
        {
               return false;
        }
        //유저가 자체DB ID로 접속할경우 확인해주는 쿼리 함수
        public Boolean UserLoad()
        {
              return false;
        }
        //자체 DB 유저 계정 생성 쿼리 함수
        public Boolean UserCreate()
        {
            return false;
        }
        //구글 계정등록 쿼리 함수
        public Boolean 구글계정생성()
        {
            return false;
        }
        //구글 계정 로그인 쿼리 함수
        public Boolean 구글로그인()
        {
            return false;
        }
        //캐시 충전 쿼리 함수
        public Boolean 캐시충전()
        {
            return false;
        }
        //유저 차단 쿼리 함수
        public Boolean 불량유저등록()
        {
            return false; 
        }
        
    }
}
