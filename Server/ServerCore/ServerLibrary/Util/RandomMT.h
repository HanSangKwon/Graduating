#pragma once
#include "stdafx.h"

#define RAND(type, maxVal)       (type) RandomMT::getInstance().rand(maxVal)

class RandomMT : public Singleton<RandomMT>
{
    uint64_t rand(int maxVal)
    {
		static uint32_t seed = 0;
        //MT19937 ���� ����
		std::mt19937 engine((uint32_t)time(nullptr) + seed++);
        //UINT64 ���� = �� 1844�� = 18,446,744,073,709,551,615(16���� 0xFFFFFFFFFFFFFFFF)�� �ֱ�
        std::uniform_int_distribution<uint64_t> distribution(0, UINT64_MAX); 
        //rand ���� �Լ������� bind
        auto generator = bind(distribution, engine);

        return (uint64_t)(generator() % maxVal);
    }
};