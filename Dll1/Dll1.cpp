//extern "C"表示动态链接库中文件名称不发生改变 ，解决C和c++之间调用的问题
#define DL1_API extern "C" _declspec(dllexport)
#include "dll.h"
#include "pch.h"
#include "string"
#include "fstream"
#include "sstream"
#include <vector>
#include <iostream>
using namespace std;
int add(int a, int b)
{
    return a + b;
}

int substract(int a, int b)
{
    return a - b;
}

char* getfilememory( char* filepath)
{
    ifstream infile;
    string t1;
    vector<string>id;
    char* ptr;
    infile.open(filepath);
    if (!infile.is_open())
    {
        return NULL;
    }
    while (!infile.eof())
    {
        infile >> t1;
        id.push_back(t1);
    }
    ptr = (char*)&id;
    infile.close();
    return ptr;
}

bool PassArrayTest(float list [],int length )
{
    for (int i = 0; i < length; i++)
    {
        list[i]++;
    }
    std::cout << "list in " << std::endl;
    return true;
}

/*多维数组测试 */
bool Pass2DimensionArrayTest(float list[2][10], int length)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            list[i][j]++;
        }
    }
    std::cout << "list in 2DimensionArray" << std::endl;
    return true;
}

/*文件测试生成数组 */
bool File2DimensionArrayTest(float list[2][10], int row,int colum,char * filepath)
{
    /*读取文件*/
    ifstream infile;
    string t1;
    vector<string>id;
    char* ptr;
    infile.open(filepath);
    if (!infile.is_open())
    {
        return NULL;
    }
    while (!infile.eof())
    {
        infile >> t1;
        id.push_back(t1);
    }
    ptr = (char*)&id;
    infile.close();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            list[i][j]++;
        }
    }
    std::cout << "list in 2DimensionArray" << std::endl;
    return true;
}
