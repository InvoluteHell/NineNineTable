      PROGRAM N
      DO I=1,9
      DO J=1,I
      WRITE(*,'(I2,A1,I1,A1,I2,$)')J,"x",I,"=",I*J
      ENDDO
      WRITE(*,*)
      ENDDO
      END