#pragma once
//�����
#ifdef DL1_API
#else
#define DL1_API extern "C" _declspec(dllimport) //�����ͻ���ʹ��ʱ
#endif


DL1_API int add(int a, int b);
DL1_API int substract(int a, int b);
DL1_API char* getfilememory(char* filepath);
DL1_API bool PassArrayTest(float list[], int length);
DL1_API bool Pass2DimensionArrayTest(float list[2][10], int length);
DL1_API bool File2DimensionArrayTest(float list[2][10], int row, int colum, char* filepath);