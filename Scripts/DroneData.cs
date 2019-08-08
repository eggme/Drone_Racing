public class DroneData{
    private float runSpeed;
    private float walkSpped;
    private float fieldLookLimitX;
    private float fieldSensitivity;

    public DroneData(float runSpeed, float walkSpped, float fieldLookLimitX, float fieldSensitivity){
        this.runSpeed = runSpeed;
        this.walkSpped = walkSpped;
        this.fieldLookLimitX = fieldLookLimitX;
        this.fieldSensitivity = fieldSensitivity;
    }

    public float getRunSpeed(){
        return runSpeed;
    }
    public void set(float runSpeed){
        this.runSpeed = runSpeed;
    }
    public float getWalkSpped(){
        return walkSpped;
    }
    public void setWalkSpped(float walkSpped){
        this.walkSpped = walkSpped;
    }
    public float getFieldLookLimitX(){
        return fieldLookLimitX;
    }
    public void setFieldLookLimitX(float fieldLookLimitX){
        this.fieldLookLimitX = fieldLookLimitX;
    }
    public float getFieldSensitivity(){
        return fieldSensitivity;
    }
    public void setFieldSensitivity(float fieldSensitivity){
        this.fieldSensitivity = fieldSensitivity;
    }
}